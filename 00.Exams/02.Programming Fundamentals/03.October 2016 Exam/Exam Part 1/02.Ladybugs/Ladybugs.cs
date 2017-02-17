using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string[] ladyBugsInout = Console.ReadLine().Split();
            int[] positions = new int[lenght];

            for (int i = 0; i < ladyBugsInout.Length; i++)
            {
                int prob = int.Parse(ladyBugsInout[i]);
                for (int j = 0; j < positions.Length; j++)
                {
                    positions[int.Parse(ladyBugsInout[i])] = 1;
                }
            }

           // Console.WriteLine(string.Join(" ", positions));

            
            string[] command = Console.ReadLine().Split();
            int bugPosition = 0;
            int newBugPOsition = 0;
            int copyNebug = newBugPOsition;
            while (!command[0].Equals("end"))
            {
                switch (command[1])
                {
                    case "right":
                        bugPosition = int.Parse(command[0]);
                        newBugPOsition = int.Parse(command[2]);
                        copyNebug = newBugPOsition;
                        for (int i = 0; i < positions.Length; i++)
                        {
                            
                            for (int j = 0; j < positions.Length; j++)
                            {
                                if (newBugPOsition >= positions.Length)
                                {
                                   
                                }
                                else
                                {
                                    if (positions[bugPosition] == 1)
                                    {
                                        newBugPOsition += copyNebug;
                                    }
                                    else
                                    {
                                        positions[newBugPOsition] = 1;
                                        
                                    }
                                }                                   
                            }
                            positions[bugPosition] = 0;
                        }
                        break;
                    case "left":
                        bugPosition = int.Parse(command[0]);
                        newBugPOsition = int.Parse(command[2]);
                        copyNebug = newBugPOsition;
                        for (int i = 0; i < positions.Length; i++)
                        {
                            
                            for (int j = 0; j < positions.Length; j++)
                            {
                                
                                if (copyNebug > 0)
                                {
                                    if (positions[bugPosition - copyNebug] == 1)
                                    {
                                        newBugPOsition -= copyNebug;
                                    }
                                    else
                                    {
                                        positions[bugPosition - copyNebug] = 1;
                                        break;
                                    }
                                }
                                else
                                {
                                    Math.Abs(newBugPOsition);
                                    if (bugPosition + Math.Abs(newBugPOsition) > positions.Length)
                                    {
                                        break;
                                    }
                                    else if (positions[bugPosition + Math.Abs(newBugPOsition)] == 1)
                                    {
                                        newBugPOsition += newBugPOsition;
                                    }
                                    else
                                    {
                                        positions[bugPosition + Math.Abs(newBugPOsition)] = 1;
                                        break;

                                    }
                                }
                                    
                                
                            }
                            positions[bugPosition] = 0;
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ",positions));
        }
    }
}
