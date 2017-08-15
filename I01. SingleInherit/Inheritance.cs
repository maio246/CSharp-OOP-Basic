public static class Program
{
    public static void Main()
    {
        var puppy = new Dog();

        puppy.Eat();
        puppy.Bark();

        var cat = new Cat();
        
        cat.Eat();
        cat.Meow();
    }
    
}

