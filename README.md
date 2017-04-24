# COP2010-P4-Text-Editor
Create a text editor in visual C#
COP2010 Project #4 50 pts – Due by 1:00 PM Saturday 12/3 
 
You are going to create a text editor application using a rich textbox to enter and edit text.  When the application runs you will be able to edit text, change colors, fonts, align text, and select rich text files to load and save.     
Objectives: 
•	Use the open and close file dialog 
•	Practice using different properties of controls 
•	Use menu items 
 
Requirements 
Read the projects and assignments requirements pdf in the course documents section of canvas.  You need to follow all of the guidelines for this project.    
1.	Richtextbox for editing text.  
2.	Group box with radio buttons for selecting colors  
a.	Four different colors with one set to black as the default; use any other three fonts  
b.	The radio button text should be the same as the color selection  
c.	Selecting a radio button will change the color of highlighted/selected text 
3.	Group box with radio buttons for selecting fonts  
a.	Four different fonts with one set to Arial as the default; use any other three colors  
b.	The radio button text should be the same as the font selection 
c.	Selecting a radio button will change the font of highlighted/selected text 
4.	Button to load file  (use) 
a.	Use open file dialog 
b.	Set default filename as COP2010.rtf (.FileName = “COP2010.rtf”)  
c.	Open file dialog filter to set file types for richtext and text files (*.rtf, *.txt) 
d.	Use RichTextBox.LoadFile Method to load file 
5.	Button to save file 
a.	Use save file dialog 
b.	Set default filename as COP2010.rtf (.FileName = “COP2010.rtf”)  
c.	Save file dialog filter to set file types for richtext and text files (*.rtf, *.txt) 
d.	Use RichTextBox.SaveFile Method to save file 
6.	Search and highlight text in richtextbox 
a.	A textbox to enter search word 
b.	Search richtextbox and highlight found text in yellow 7. The form will have a menu that includes:  
a.	File , open, save, exit 
b.	Edit, find 
8.	A clear button to clear the richtextbox.   
9.	An exit button to exit the application.   
Notes: Use as many variables as you like but all must be named using camel case and with the required naming convention and methods must be named using pascal case.       
Example form: not required to match layout, but must have all text boxes, buttons, labels, etc.   
  
 
  
  
Grading Rubric (possible 50 pints): 
A submitted project must compile and run or it will be graded with zero points 
Description 	Itemized Value 	Total 
Possible 	Total Earned 
Radio buttons change selected text color. 	2 pts each  	8 	  
Radio buttons change selected text font. 	2 pts each 	8 	  
Open and close file dialog to load and save files  with filter for txt, rtf 	5 pts each 	10 
 	  
Find and highlight text 	All or nothing 	4 	 
Menu items 	1 pt each 	4 	 
Correct naming of all event handlers and variables 	All or nothing 	5 	 
Proper comments and documentation 	All or nothing 
 	5 	 
Appearance: form layout, clean code: no extra event handlers, variables, etc.  	 	4 	 
Clear button  	All or nothing 	1 	 
Exit button closes application 	All or nothing 	1 	 
Extra Credit – groupbox to align text left, right, and center 	All or nothing 	2 	 

