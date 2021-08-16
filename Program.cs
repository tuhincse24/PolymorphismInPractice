using System;

namespace PolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type1 = typeof(ClassWithOverride);
            GetMemberInfoFromClass(ref type1);
            Type type2 = typeof(ClassWithNew);
            GetMemberInfoFromClass(ref type2);

            Console.ReadLine();

            SportSedanCar sportSedanCar = new();
            Console.WriteLine($"OrdinayCar : HP : {((OrdinayCar)sportSedanCar).GetHorsePower()}");
            Console.WriteLine($"Sedan : HP : {((SedanCar)sportSedanCar).GetHorsePower()}");
            Console.WriteLine($"SportSedan : HP : {sportSedanCar.GetHorsePower()}");

            Console.ReadLine();

            Console.WriteLine($"HP Diff : OrdinayCar -> Sedan : " + $"{((SedanCar)sportSedanCar).GetHorsePower() - ((OrdinayCar)sportSedanCar).GetHorsePower()}");
            Console.WriteLine($"HP Diff : Sedan -> SportSedan : " + $"{sportSedanCar.GetHorsePower() - ((SedanCar)sportSedanCar).GetHorsePower()}");
            Console.WriteLine($"HP Diff : OrdinayCar -> SportSedan : " + $"{sportSedanCar.GetHorsePower() - ((OrdinayCar)sportSedanCar).GetHorsePower()}");

            SportSedanCar sportSedanCar2 = new();
            SedanCar sedanCar = new();
            OrdinayCar baseCar = new();
            Console.WriteLine($"HP Diff : OrdinayCar -> Sedan : " + $"{sedanCar.GetHorsePower() - baseCar.GetHorsePower()}");
            Console.WriteLine($"HP Diff : Sedan -> SportSedan : " + $"{sportSedanCar2.GetHorsePower() - sedanCar.GetHorsePower()}");
            Console.WriteLine($"HP Diff : OrdinayCar -> SportSedan : " + $"{sportSedanCar2.GetHorsePower() - baseCar.GetHorsePower()}");
        }
        public static void GetMemberInfoFromClass(ref Type type)
        {
            System.Reflection.BindingFlags flags =
                System.Reflection.BindingFlags.Instance
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.FlattenHierarchy;
            System.Reflection.MemberInfo[] memberInfos = type.GetMembers(flags);
            Console.WriteLine(
                $"----------\n" +
                $"Type {type.Name} has {memberInfos.Length} members:" +
                $"\n----------"
               );
            foreach (var member in memberInfos)
            {
                System.Text.StringBuilder str = new();
                str.Append($"{member.Name} ({member.MemberType}): ");
                str.Append($"Declared by {member.DeclaringType}");
                Console.WriteLine(str.ToString());

            }
        }
    }
}
