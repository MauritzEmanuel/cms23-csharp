using _03_Records.Records;

//Records går aldrig att ändra på, utan bevarar värdet det vart givet.
var user = new User("Emanuel", "Lundbergh", "Supermejl@gmail.com");

// user.firstName = "Tommy" <- så får/kan man inte göra

Console.WriteLine($"{user.firstName} {user.lastName} <{user.email}>");
Console.ReadKey();