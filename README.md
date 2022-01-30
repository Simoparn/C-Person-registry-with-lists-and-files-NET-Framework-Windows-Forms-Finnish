# C-Person-registry-with-lists-and-files-NET-Framework-Windows-Forms-Finnish

 Simple Person registry with lists and text files, C#, NET Framework, Windows Forms, (Finnish), incomplete

  UI classes:

    Form1.cs -> Main view, has methods for the initial loading of the full registry and for adding new persons to the runtime list. Duplicates are immediately deleted upon creation. 
    Uusihenkilölomake.cs -> Form for creating new person records.
    
    
 
  Backend classes:
  
    Program.cs -> Main loop
    Henkilö.cs -> Class for person data, constructor can tell the difference between loading the full registry from long-term storage and creating new records with user input
    through boolean parameters. Has a method for removing the corresponding record line from the text file (henkilorekisterintiedot.txt).
    
  Data:
  
    henkilorekisterintiedot.txt -> Comma-separated values