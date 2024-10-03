/*
 5. Correct Misspelled Customer Name: Update the FirstName and LastName of a
 customer who was entered with a misspelled name.
*/

Update Customer set FirstName = 'Selena' , LastName = 'Gomez' 
where FirstName = 'Justin' AND LastName = 'Beiber' 
