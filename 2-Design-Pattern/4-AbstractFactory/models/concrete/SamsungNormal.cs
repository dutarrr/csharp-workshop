namespace _4_AbstractFactory.models
{
    class SamsungNormal : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Normal :)\nRAM: Nooo\nCamera: Nooooo\n";
        }
    }
}