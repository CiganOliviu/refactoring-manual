package main

import "fmt"

func main() {

	number := 123
	factor := 5

	number -= getPrimeNumber(factor)
	number += getFibonacciNumber(factor)

	fmt.Println(number)
}
