﻿using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Bark();
            dog.Bark();

            Puppy puppy = new Puppy();

            puppy.Weep();

            var cat = new Cat();
            cat.Meow();

        }
    }
}
