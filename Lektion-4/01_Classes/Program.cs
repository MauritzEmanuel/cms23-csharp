using _01_Classes.Service;

/*
    Access modifiers
    -----------------------------------------------------------------------------------------------
    private         accessbara bara inom scopet (dvs { } som variabeln ligger inom.
    public          accessbar överallt i hela din solution, dvs även mellan olika projekt.
    internal        accessbar överallt i hela ditt projekt, men inte mellan olika projekt.
 
 
 */



// Vi gör en instans av en customerService så vi kan använda den
var customerService = new CustomerService();

customerService.GetCustomers();