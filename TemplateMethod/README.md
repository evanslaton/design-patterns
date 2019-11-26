# The Template Method Pattern
Defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

## Desing Principles
* The Hollywood Principle - Don't call us, we'll call you.

## Hook
A method that is declared in the abstract class, but only given an empty or default implementation. This gives subclasses the ability to "hook into" the algorithm at various points, if they wish; a subclass is also free to ignore the hook.

## Dependency Rot
When high-level components depend on low-level components depending on high-level components.