using System;

using System.Linq;
using System.IO;

using System.Text;
using System.Collections;

using System.Collections.Generic;

class Player

{
    static void Main(string[] args)
    
{
        string[] inputs = Console.ReadLine().Split(' ');
     
   int lightX = int.Parse(inputs[0]);
int lightY = int.Parse(inputs[1]);      
int initialTX = int.Parse(inputs[2]);      
int initialTY = int.Parse(inputs[3]);      
int posTX = initialTX;
      
  int posTY = initialTY;
             
while (true)
        
{
            
int remainingTurns = int.Parse(Console.ReadLine());            
string kydaidiX = "";
            
string kydaidiY = "";
            
if (posTX < lightX)
            
{ kydaidiX = "E";
               
 posTX++;
            
} else if (posTX > lightX)
            
{ kydaidiX = "W";
                
posTX--;
            
}
            
            
if (posTY > lightY)
            
{ kydaidiY = "N";
                
posTY--;
            
} else if (posTY < lightY)
            
{  kydaidiY = "S";
                
posTY++;
            
}

            
Console.WriteLine(kydaidiY + kydaidiX);
        
}
}
}