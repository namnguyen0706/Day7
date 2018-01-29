using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car car1 = new Car();
            // Car car2 = new Car("Mercerdes AAA","Mercedes");
            // System.Console.WriteLine("So luong xe duoc tao ra la: "+ Car.countCar);

            // Student student1 = new Student("nguyen van a",21,54);
            // student1.Eeat();
            Caculator.Add(3,5);
            Caculator.Divide(3,5);
        }
    }

    class Car
    {
        public string Color { get; set; }
        public int Year  { get; set; }
        public string Brand { get; set; }
        
        public int Mileage { get; set; }

        public static int countCar = 0;

        public Car(){
            countCar++;
        }
        public Car(string color, string brand){
            color = Color;
            brand = Brand;
            countCar++;
        }
        public Car (string color, int year,string brand, int mileage){
            color = Color;
            year = Year;
            brand = Brand;
            mileage = Mileage;
            countCar++;
        }
        

        
        
    }

    // bai 2:
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public Person(){}// contructor mac dinh.
        public Person(string name, int age,int weight )
        {
            name = Name;
            age = Age;
            weight = Weight;
        }
        public  void Say() 
        {
            System.Console.WriteLine("Hello");
        }
        public void Eeat()
        {
            System.Console.WriteLine("Eat");
        }    
    }
    class Student: Person
    {
        public Student(): base(){}
        public Student(string name, int age,int weight) : base( name, age, weight)
        {
        
        }
        public void subject(){
            System.Console.WriteLine("sinh vien phai hoc tieng anh ");
        }
        public void tuitionFee()
        {
            System.Console.WriteLine("Tuition Fee is 3tr");
        }
    }
    class Teacher : Person
    {
        public Teacher(string name, int age, int weight): base(name, age, weight)
        {
           
        }
        public void job()
        {
            System.Console.WriteLine("nghe nghiep cua toi la giao vien");
        }
        public void salary()
        {
            System.Console.WriteLine("my salary is 10tr");
        }
        
    }

    // bai 3: 
    static class Caculator
    {   
        public static void Add(int a, int b)
        {
            System.Console.WriteLine("tong la: "+(a+b));
        }
        public static void Subtract(int a, int b)
        {
            System.Console.WriteLine("hieu cua 2 so la: "+(a-b));
        }
        public static void Multiply(int a, int b)
        {
            System.Console.WriteLine("tich cua 2 so la: "+(a*b));
        }
        public static void Divide(double a, double b)
        {
            System.Console.WriteLine("Thuong cua 2 so: "+(a/b));
        }
        
    }
}
