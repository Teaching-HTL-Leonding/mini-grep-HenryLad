if (args.Length == 0) { System.Console.WriteLine("There were no Arguments passed. Please try again"); }
;
void Main()
{
  

      string SearchPath = args[0];
      string SearchPattern = args[1];
      string SearchWord = args[2];
      string[] lines = File.ReadAllLines(SearchPath);
      bool containsSearchString = File.ReadAllText(SearchPath).Contains(SearchWord);
      if (containsSearchString)
      {
         for(int j = 0; j < lines.Length; j++)
         {
            if (lines[j].Contains(SearchWord))
            {
               System.Console.WriteLine(lines[j]);
            }
         }
         System.Console.WriteLine(Directory.GetFiles(SearchPath, SearchPattern, SearchOption.AllDirectories).FirstOrDefault());
         
        

      }
      else 
      {
         System.Console.WriteLine("Your search word was not found in the files");
      }
   }

Main();