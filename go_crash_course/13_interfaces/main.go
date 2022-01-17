package main

import (
	"fmt"
	"math"
)

//define shape
type Shape interface {
	area() float64
}

type Circle struct {
	x, y, radius float64
}

type Rectangle struct {
	width, height float64
}

func (c Circle) area() float64 {
	return math.Pi * c.radius * c.radius
}

func (r Rectangle) area() float64 {
	return r.width * r.height
}

func getArea(s Shape) float64 {
	return s.area()
}
func main() {
	fmt.Println("sad")
	circle := Circle{0, 0, 5}
	rectangle := Rectangle{10, 5}
	fmt.Println(circle.area())
	fmt.Println(getArea(circle))
	fmt.Println(rectangle.area())
	fmt.Println(getArea(rectangle))
}
