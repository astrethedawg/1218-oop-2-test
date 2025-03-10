using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace test_oop2sd
{
    public class MusicApp
    {
    public void Start() 
        {
          
            string filePath = "Camera.txt";
           
            string[] lines = File.ReadAllLines(filePath);
            var cameras = new List<Cameras>();
            foreach (string line in lines)
            {
                string[] columns = line.Split("-"); // rozdelime radek 
                var product = new Cameras
                {
                    Id = int.Parse(columns[0]),
                   Lenght = int.Parse( columns[1]),
                    Title =  columns[2],
                   Artist = columns[3],
                    Year = int.Parse(columns[4]),
                   Plays = int.Parse(columns[5]),
                    Genre = columns[6],
                   Liked = bool.Parse (columns[7]),
                };
cameras.Add(product);
           
            
            
            }
            // liked bool
            
          
                
            
            
            
            
           
            
            
            
            
            //vypis informaci 

          Cameras cameras2 = new Cameras();
           foreach (Cameras cam in cameras)
            Console.WriteLine(cam);
           
            
            
            // prumer 
            int totalLenght = 0;

            foreach (var cam in cameras) { totalLenght += cam.Lenght; }
        
            int averageLenght = totalLenght / cameras.Count;
            Console.WriteLine($"prumerna delka  {averageLenght} sekund $");
        }
       
        
        
        
        
        
      }

 }

