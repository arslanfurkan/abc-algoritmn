using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ABCalgoritmn
{
    class ABCManager
    {
        private int popSize;
        private int iterasyon;
        private int denemeLimit;
        private int foodResourcesSize;
        private int minValue = -10;
        private int maxValue = 10;
        private int olasilik;
        private int isciAri;
        private int gozcuAri;
        private int kasifAriOlanSayisi = 0;
        List<FoodResource> foods;
        Random random;
       
        public ABCManager(int popSize, int iterasyon, int denemeLimit, int olasilik)
        {
            this.popSize = popSize;
            isciAri = popSize / 2;
            gozcuAri = popSize / 2;
            this.olasilik = olasilik;
            this.iterasyon = iterasyon;
            this.denemeLimit = denemeLimit;
            foodResourcesSize = popSize / 2;
            foods = new List<FoodResource>(3);
            random = new Random();
        }



        public ChartItems Run()
        {
            ChartItems items = new ChartItems();
            for (int i = 0; i < foodResourcesSize; i++)
            {
                YeniBesinUret();
            }



         
            for (int j = 0; j < iterasyon; j++)
            {
                //isci ari
                for (int m = 0; m < foods.Count; m++)
                {
                    Guncelleme(m,false);
                }

                //gozcu ari
                for (int k = 0; k < gozcuAri; k++)
                {
                   
                    
                    for (int m = 0; m < foods.Count; m++)
                    {
                        var toplamFitness = foods.Sum(x => x.fiti);
                        double besinOlasilik = foods[m].OlasilikDegeri(toplamFitness);
                        if (besinOlasilik > olasilik)
                        {
                            Guncelleme(m,true);
                        }
                        else
                        {
                            foods[m].tryLimit--;
                        }


                    }

                }

                //kasif ari
                for (int m = 0; m < foods.Count; m++)
                {
                    if (foods[m].tryLimit <= 0)
                    {
                        foods.Remove(foods[m]);
                        YeniBesinUret();
                        m = m - 1;
                        kasifAriOlanSayisi++;
                    }
                   
                }


                var sumfit = foods.Sum(x => x.fiti);
                double ort = sumfit / foods.Count;
                double best = foods.Max(x => x.fiti);
                items.BestFit.Add(best);
                items.OrtFit.Add(ort);
                
            }


            FileStream file = new FileStream(@"holdertablefunction.txt", FileMode.Append, FileAccess.Write);
            StreamWriter yaz = new StreamWriter(file, Encoding.GetEncoding("iso-8859-9"));

            for(int i = 0; i < items.BestFit.Count; i++)
            {
                yaz.WriteLine("Iterasyon: "+(i+1)+"- Best fit: "+items.BestFit[i]+ "- Ortalama fit: " + items.OrtFit[i]);
            }
            yaz.WriteLine("---------------------------------------------------------------------------------------------------");

            yaz.Close();
            file.Close();


            return items;


        }
        
        public void YeniBesinUret()
        {
            FoodResource food = new FoodResource();
            food.x1 = getRandomNumberBetween(-10, 10);
            food.x2 = getRandomNumberBetween(-10, 10);
            food.fi = GoalFunc(food.x1, food.x2);
            food.fiti = FitnessFunc(food.fi);
            food.tryLimit = denemeLimit;
            foods.Add(food);
        }


        public void Guncelleme(int selectedIndex,bool gozcu)
        {
            FoodResource tempfood = new FoodResource();
            int difFoodIndex = getRandomIndexwithException(selectedIndex);//for neighbor index
            int randomParameterIndex = getRandomParameterIndex();

            double delta = getRandomDeltaNumber();
            if (randomParameterIndex == 1)
            {

                tempfood.x1 = foods[selectedIndex].x1 + (delta * (foods[selectedIndex].x1 - foods[difFoodIndex].x1));
                tempfood.x2 = foods[selectedIndex].x2;

            }
            else if (randomParameterIndex == 2)
            {
                tempfood.x1 = foods[selectedIndex].x1;
                tempfood.x2 = foods[selectedIndex].x2 + (delta * (foods[selectedIndex].x2 - foods[difFoodIndex].x2));
            }
            tempfood.tryLimit = denemeLimit;



            if (tempfood.x1 > maxValue)
            {
                tempfood.x1 = maxValue;
            }
            if (tempfood.x1 < minValue)
            {
                tempfood.x1 = minValue;
            }

            if (tempfood.x2 > maxValue)
            {
                tempfood.x2 = maxValue;
            }
            if (tempfood.x2 < minValue)
            {
                tempfood.x2 = minValue;
            }

            tempfood.fi = GoalFunc(tempfood.x1, tempfood.x2);
            tempfood.fiti = FitnessFunc(tempfood.fi);
            if (tempfood.fiti > foods[selectedIndex].fiti)
            {
                foods[selectedIndex] = tempfood;
                foods[selectedIndex].tryLimit = denemeLimit;
            }
            else 
            {
                if(!gozcu)
                foods[selectedIndex].tryLimit--;
            }

        }


        public double getRandomNumberBetween (int from,int to)
        {
           
            return random.Next(from, to+1) * random.NextDouble();
        }
        public int getRandomIndexwithException(int except)
        {
            int num;
            do
            {
                num = random.Next(0, foodResourcesSize-1);
            }while (except == num);

            return num;

        }
        public int getRandomParameterIndex()
        {
            return random.Next(1,3);
        }
        public double getRandomDeltaNumber()
        {
            int deger = random.Next(0, 2);

            if (deger == 0)
            {
                return -1 * random.NextDouble();
            }
            else
            {
                return 1 * random.NextDouble();
            }
        }


        public double GoalFunc(double x, double y)
        {
            double sonuc = -Math.Abs(Math.Sin(x) * Math.Cos(y) * Math.Exp(Math.Abs(1 - (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) / Math.PI)));
            // -10 <= x,y <=10
            return sonuc;
        }

        public double FitnessFunc(double fi)
        {
            double result;
            if (fi >= 0)
            {
                result = 1 / (1 + fi);
            }
            else
            {
                result = 1 + Math.Abs(fi);
            }
            return result;
        }
    }


    class FoodResource
    {
        public double x1;
        public double x2;
        public double fi;
        public double fiti;
        public double tryLimit;

        public double OlasilikDegeri(double toplamFitness)
        {
            return (fiti / toplamFitness);
        }
       
    }

    public class ChartItems
    {
        public List<double> BestFit;
        public List<double> OrtFit;
        public ChartItems()
        {
            BestFit = new List<double>();
            OrtFit = new List<double>();
        }
    }

  
}
