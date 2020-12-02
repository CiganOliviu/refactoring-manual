package main

import "fmt"

func assert(condition bool) bool {

	if condition == false {
		fmt.Printf("assertion failed\n")
	}

	return true
}

func testGetFibonacciNumber() {

	assert(getFibonacciNumber(8) == 21)
	assert(getFibonacciNumber(12) == 144)
	assert(getFibonacciNumber(2) == 1)
}

func testGetPrimeNumber() {

	assert(getPrimeNumber(1) == 2)
	assert(getPrimeNumber(141) == 811)
	assert(getPrimeNumber(83) == 431)
}

func testEnrichNumber() {

	assert(enrichNumber(123, 5) == 117)
	assert(enrichNumber(0, 12) == 107)
}