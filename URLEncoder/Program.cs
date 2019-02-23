using System;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RunAgain = true;

            while (RunAgain == true)
            {
            string Base = "https://companyserver.com/content/";
            string ProjectName = null;
            string ActivityName = null;
            string Files = "/files/";
            string Dash = "/";
            string Report = "Report.pdf";
            string CompiledStrings = null;
            string URLAgain = null;
            string NewProjectName = null;
            string NewActivityName = null;
            bool ControlCharFound = false;
            bool ControlCharFound2 = false;
              
            Console.WriteLine("This program will generate a URL based on your input");
            Console.WriteLine("");




                    try
                    {
                        //This will get a string from the user, then convert each character and proceed to check the 
                        //characters by converting them to a string

                        Console.WriteLine("Please enter Project Name");
                        ProjectName = Console.ReadLine();

                        
                        foreach (char character in ProjectName)
                        {
                         
                        String ProjectString = character.ToString();
                        

                        byte Conversion = Convert.ToByte(character);

                        if ((character >= 0x00 && character <= 0x1F) || character == 0x7F)
                        {
                            Console.WriteLine("A Control character was found, please try again");
                            Console.WriteLine("URL generated will not encode your input");
                            ControlCharFound = true;
                            break;

                        }

                        else if (ProjectString == " ")
                            {
                                NewProjectName += "%20";
                                
                            }

                            else if (ProjectString == ";")
                            {
                                NewProjectName += "%3B";
                                
                            }

                            else if (ProjectString == "/")
                            {
                                NewProjectName += "%2F";
                            } else if (ProjectString == "?")
                            {
                                NewProjectName += "%3F";
                            }

                            else if (ProjectString == ":")
                            {
                                NewProjectName += "%3A";
                            }

                            else if (ProjectString == "@")
                            {
                                NewProjectName += "%40";
                            }

                            else if (ProjectString == "&")
                            {
                                NewProjectName += "%26";
                            }

                            else if (ProjectString == "=")
                            {
                                NewProjectName += "%3D";
                            }

                            else if (ProjectString == "+")
                            {
                                NewProjectName += "%2B";
                            }

                            else if (ProjectString == "$")
                            {
                                NewProjectName += "%24";
                            }

                            else if (ProjectString == ",")
                            {
                                NewProjectName += "%2C";
                            }


                            //"Troublesome" characters
                            else if (ProjectString == "{")
                            {
                                NewProjectName += "%7B";
                            }

                            else if (ProjectString == "}")
                            {
                                NewProjectName += "%7D";
                            }

                            else if (ProjectString == "|")
                            {
                                NewProjectName += "%7C";
                            }


                            else if (ProjectString == @"\")
                            {

                                NewProjectName += "%5C";
                            }


                            else if (ProjectString == "^")
                            {
                                NewProjectName += "%88";
                            }

                            else if (ProjectString == "[")
                            {
                                NewProjectName += "%5B";
                            }

                            else if (ProjectString == "]")
                            {
                                NewProjectName += "%5D";
                            }

                            else if (ProjectString == "`")
                            {
                                NewProjectName += "%60";
                            }


                            //Delimiter Characters
                            else if (ProjectString == "<")
                            {
                                NewProjectName += "%3C";
                            }

                            else if (ProjectString == ">")
                            {
                                NewProjectName += "%3E";
                            }

                            else if (ProjectString == "#")
                            {
                                NewProjectName += "%23";
                            }

                            else if (ProjectString == "%")
                            {
                                NewProjectName += "%25";
                            }

                            else if (ProjectString == "%00")
                            {
                                Console.WriteLine("Nope");
                            }
                            else if (ProjectString == @"""")
                            {
                                NewProjectName += "%22";
                            }

                           



                        else
                        {

                            NewProjectName += ProjectString;
                        }


                    } 
                    //^closes for loop


                    if (ControlCharFound == true)
                    {
                        continue;
                    }


                    Console.WriteLine("Please enter Activity Name");
                    ActivityName = Console.ReadLine();

                    foreach (char character in ActivityName)
                    {
                        String ActivityString = character.ToString();
                        byte Conversion = Convert.ToByte(character);

                        if ((Conversion >= 0x00 && Conversion <= 0x1F) || Conversion == 0x7F)
                        {
                            Console.WriteLine("A Control character was found, please try again");
                            Console.WriteLine("URL generated will not encode your input");
                            ControlCharFound = true;
                            break;

                        }

                        else if (ActivityString == " ")
                        {
                            NewActivityName += "%20";
                        }

                        //Query Characters
                        else if (ActivityString == ";")
                        {
                            NewActivityName += "%3B";
                        }

                        else if (ActivityString == "/")
                        {
                            NewActivityName += "%2F";
                        }

                        else if (ActivityString == "?")
                        {
                            NewActivityName += "%3F";
                        }

                        else if (ActivityString == ":")
                        {
                            NewActivityName += "%3A";
                        }

                        else if (ActivityString == "@")
                        {
                            NewActivityName += "%40";
                        }

                        else if (ActivityString == "&")
                        {
                            NewActivityName += "%26";
                        }

                        else if (ActivityString == "=")
                        {
                            NewActivityName += "%3D";
                        }

                        else if (ActivityString == "+")
                        {
                            NewActivityName += "%2B";
                        }

                        else if (ActivityString == "$")
                        {
                            NewActivityName += "%24";
                        }

                        else if (ActivityString == ",")
                        {
                            NewActivityName += "%2C";
                        }


                        //"Troublesome" characters
                        else if (ActivityString == "{")
                        {
                            NewActivityName += "%7B";
                        }

                        else if (ActivityString == "}")
                        {
                            NewActivityName += "%7D";
                        }

                        else if (ActivityString == "|")
                        {
                            NewActivityName += "%7C";
                        }


                        else if (ActivityString == @"\")
                        {

                            NewActivityName += "%5C";
                        }


                        else if (ActivityString == "^")
                        {
                            NewActivityName += "%88";
                        }

                        else if (ActivityString == "[")
                        {
                            NewActivityName += "%5B";
                        }

                        else if (ActivityString == "]")
                        {
                            NewActivityName += "%5D";
                        }

                        else if (ActivityString == "`")
                        {
                            NewActivityName += "%60";
                        }


                        //Delimiter Characters
                        else if (ActivityString == "<")
                        {
                            NewActivityName += "%3C";
                        }

                        else if (ActivityString == ">")
                        {
                            NewActivityName += "%3E";
                        }

                        else if (ActivityString == "#")
                        {
                            NewActivityName += "%23";
                        }

                        else if (ActivityString == "%")
                        {
                            NewActivityName += "%25";
                        }


                        else if (ActivityString == @"""")
                        {
                            NewActivityName += "%22";
                        }

                      
                       else
                      {
                          
                          NewActivityName += ActivityString;
                      }

                    }

                    if (ControlCharFound2 == true)
                    {
                        continue;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                    return;
                }

                finally
                {               
                    CompiledStrings = Base += NewProjectName += Files += NewActivityName += Dash += NewActivityName += Report;
            
                    ProjectName = null;
                    ActivityName = null;
               
                    Console.WriteLine("Result URL:");
                    Console.WriteLine(CompiledStrings);

                    Console.WriteLine("Would you like to make another URL?");
                    Console.WriteLine("Type Yes to do so, otherwise typing anything else will end this program");
                    URLAgain = Console.ReadLine();

                    if (URLAgain == "Yes")
                    {
                        ProjectName = null;
                        ActivityName = null;
                        RunAgain = true;

                    }

                    else if (URLAgain != "Yes")
                    {
                        RunAgain = false;
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}

