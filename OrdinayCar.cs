
namespace PolymorphismPractice
{
    class OrdinayCar
    {
        protected int HorsePower = 300;
        public virtual int GetHorsePower()
        {
            return HorsePower;
        }
    }

    class SedanCar : OrdinayCar
    {
        protected int CoolerUpgrade = 50;
        public new int GetHorsePower()
        {
            return base.GetHorsePower() + CoolerUpgrade;
        }
    }

    class SportSedanCar : SedanCar
    {
        protected int TurboHorsePower = 80;
        public new int GetHorsePower()
        {
            return base.GetHorsePower() + TurboHorsePower;
        }
    }
}
