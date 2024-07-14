Repository that contains a C# project. 

The project consists of a library system. Users can manage books, customers, borrows and fines. Users can add new books and customers and remove them from the system. Users can manage borrows where there are a limited number of books that a customer can borrow. When returning a book a fine may be applied. In this case, customers can pay the fine in several payments.

Whether books or customers can not be removed from the system if some circunstances occur. A book can not be removed if is borrowed. A customer can not be removed if he has a book borrowd or has a fine to be paid.

The project uses Oracle as a database and SQLDeveloper to manage it. Visual Studio 2019 was used to code the program.