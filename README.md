# C-Person-registry-with-lists-and-files-NET-Framework-Windows-Forms-Finnish

 Simple Person registry with lists and text files, C#, NET Framework, Windows Forms, (Finnish), incomplete

## Code structure

###  UI classes

    Form1.cs -> Main view, has methods for the initial loading of the full registry and for adding new persons to the runtime list. Duplicates are immediately deleted upon creation. 
    Uusihenkilölomake.cs -> Form for creating new person records.
    Henkilötietojenmuokkauslomake.cs -> Form for modifying existing person records. (incomplete)
    
 
###  Backend classes
  
    Program.cs -> Main loop, methods for loading the registry file into a list object, retrieving individual records from the registry file, saving a new record, modifying existing records.
    Henkilö.cs -> Class for individual person data, doesn't handle loading the full registry to a list. Constructor can tell the difference between loading the full registry from long-term storage and creating new records with user input
    through boolean parameters. Has a method for removing the corresponding record line from the text file (henkilorekisterintiedot.txt).
    
###  Data
  
    henkilorekisterintiedot.txt -> Person data, Comma-separated values
    henkilorekisteriohjelmanasetukset.txt -> Program settings (incomplete)

## Notes, test

    Bin and obj folders are left out of this repository