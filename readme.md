### Extension Method in C#
In C#, the extension method concept allows you to add new methods in the existing class or in the structure without modifying the source code of the original type and you do not require any kind of special permission from the original type and there is no need to re-compile the original type. 

1. They are usually replacing static methods.
Extension methods are most commonly based on things that would otherwise have been static methods, not class methods. They look like class methods, but they aren't really.

Extension methods simply shouldn't be considered an alternative for class methods; but rather as a way to give otherwise syntactically ugle static methods a "class methody" look and feel.

2. When your intended method is specific to a consuming project but not the source library.
Just because you develop both the library and the consumer doesn't mean that you're willing to put the logic wherever it fits.

3. If you think data classes should only contain data.

4. Helper methods
In most projects, I tend to end up with helper classes. These are static classes that usually provide some collection of methods for easy formatting.

Extension methods:
* Allow you to avoid polluting the core API of a class,
* Not only allow method-chaining style, but allow it to more flexibly handle null values since an extension method called from a null value simply receives the null as its first argument,
* Prevent you from accidentally accessing/modifying private/protected state in a method that shouldn't have access to it

### Recursion
Recursive functions are functions that calls itself.
