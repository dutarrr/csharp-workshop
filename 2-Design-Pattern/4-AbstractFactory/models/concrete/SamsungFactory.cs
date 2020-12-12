namespace _4_AbstractFactory.models
{
    class SamsungFactory : IMobilePhoneFactory
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone GetNormalPhone()
        {
            return new SamsungNormal();
        }
    }
}