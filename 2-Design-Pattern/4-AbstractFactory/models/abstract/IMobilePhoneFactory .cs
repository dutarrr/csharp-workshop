namespace _4_AbstractFactory.models
{
    interface IMobilePhoneFactory
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}