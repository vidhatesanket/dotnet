using System;
using System.Collections.Generic;
using BOL;
using DAL;


IDBManager dbm=new DBManager();

bool status=true;
// Console based Menu driven User Interface
while(status)
{
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  records");
    Console.WriteLine("2. Insert  new record");
    Console.WriteLine("3. Update existing record");
    Console.WriteLine("4. Delete existing record");
    Console.WriteLine("5. Exit");

    switch(int.Parse(Console.ReadLine()))
    {
        //Display Departments
        case 1:
        {
            List<Player> plist=dbm.GetAll();

            foreach (var p in plist)
            {
                Console.WriteLine(" Id: {0}, Name: {1}, Skills: {2}",
                                    p.Pid,p.Pname,p.Skills);
            }
        }
        break;
            
        //Insert new  Department
        case 2:
            var newDept = new Player()
            {
                Pid = 343,
                Pname = "data",
                Skills = "skills" 
                
            };
            dbm.Insert(newDept);
        break;

        // Update existing Department
        case 3:
        {
            var p = new Player(){
                Pid = 17,
                Pname = "a",
                Skills = "b"   
            };
            dbm.Update(p);
        }
        break;
    
        // Delete existing Department
        case 4:
            dbm.Delete(343);
        break;
    
        //Exit from loop
        case 5:
            status = false;
        break;
    }
}


