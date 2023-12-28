namespace dal;
using EmployeePackage;
using System.Collections.Generic;
public static class HRDBManager{
  

    public static List<Employee> getList(){

        List<Employee> plist=new List<Employee>();
        plist.Add(new Employee{Id=18,Name="Somesh",Path="../Images/Somesh.jpg"});
        plist.Add(new Employee{Id=56,Name="Pranav",Path="../Images/Pranav.jpg"});
        plist.Add(new Employee{Id=67,Name="Rutik",Path="../Images/Rutik.jpg"});
        plist.Add(new Employee{Id=68,Name="Abhishek",Path="../Images/Abhishek.jpg"});
        plist.Add(new Employee{Id=69,Name="Ameya",Path="../Images/Ameya.jpg"});

        return plist;
    }

}