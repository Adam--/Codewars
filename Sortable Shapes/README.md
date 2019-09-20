# Sortable Shapes
_6 kyu_

from https://www.codewars.com/kata/586669a8442e3fc307000048

## Description
Although shapes can be very different by nature, they can be sorted by the size of their area.

Task:
- Create different shapes that can be part of a sortable list. The sortorder is based on the size of their respective areas:
    - The area of a Square is the square of its side
    - The area of a Rectangle is width multiplied by height
    - The area of a Triangle is base multiplied by height divided by 2
    - The area of a Circle is the square of its radius multiplied by π
    - The area of a CustomShape is given

- The default sort order of a list of shapes is ascending on area size:
    ```
    var side = 1.1234D;
    var radius = 1.1234D;
    var base = 5D;
    var height = 2D;

    var shapes = new List<Shape>{ new Square(side),
                                new Circle(radius),
                                new Triangle(base, height) };
    shapes.Sort();
    ```

- Use the correct π constant for your circle area calculations:
    ```
    System.Math.PI
    ```