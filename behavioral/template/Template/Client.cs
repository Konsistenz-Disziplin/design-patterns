namespace Template;

public class Client
{

    public void Do(AbstractClass passedClass)
    {
        passedClass.TemplateMethod();
    }
}
