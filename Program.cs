using System;
using System.IO;

namespace midtermExam{
    class program{
        static void Main(string[] arg){
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float w1 =float.Parse(Console.ReadLine());
            float h1 =float.Parse(Console.ReadLine());
            float x2 =float.Parse(Console.ReadLine());
            float y2 =float.Parse(Console.ReadLine());
            float w2 =float.Parse(Console.ReadLine());
            float h2 =float.Parse(Console.ReadLine());

            /*
            float[] l1 = {x1+w1-h1,y1+w1-h1};
            float[] r1 = {x1+w1+h1,y1+w1+h1};
            float[] l2 = {x2+w1-h1,y2+w2-h2};
            float[] r2 = {x2+w2+h2,y2+w2+h2};
            */
            float[] l1 = {x1-w1,y1-h1};
            float[] r1 = {x1+w1,y1+h1};
            float[] l2 = {x2-w2,y2-h2};
            float[] r2 = {x2+w2,y2+w2};

/*
            Console.WriteLine(l1[0] + "," + l1[1]);
            Console.WriteLine(r1[0] + "," + r1[1]);
            Console.WriteLine(l2[0] + "," + l2[1]);
            Console.WriteLine(r2[0] + "," + r2[1]);
      */     
            Console.WriteLine(CheckAnwser(overlappingArea(l1,r1,l2,r2)));

            
            
        }

        static float overlappingArea(float[] l1,float[] r1,float[] l2,float[] r2){

            float area1 = Math.Abs(l1[0] - r1[0]) * Math.Abs(l1[0] - r1[0]);
            float area2 = Math.Abs(l2[1] - r2[1]) * Math.Abs(l2[1] - r2[1]);

            float x_dist = (Math.Min(r1[0], r2[0]) - Math.Max(l1[0], l2[0]));
            float y_dist = (Math.Min(r1[1], r2[1]) - Math.Max(l1[1], l2[1]));
            
            //Console.WriteLine(area1);
           // Console.WriteLine(area2);

            float areaI = 0 ;
             if (x_dist > 0 && y_dist > 0) {
                     areaI = x_dist * y_dist;
            }
            //Console.WriteLine(areaI);
            return (areaI);
        }

        static string CheckAnwser(float areaI){

            if(areaI > 8 ){
                return "Too Much Overlaping";
            }else if (areaI < 8 && areaI > 0){
                return "Not Much Overlaping";
            }else if (areaI == 0){
                 return "No Overlaping";
            }
            return "No Overlaping";
        }
    }
}