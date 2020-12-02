package main

func getFibonacciNumber(factor int) int {

	if factor == 1 || factor == 2 {
		return 1
	}

	return getFibonacciNumber(factor - 1) + getFibonacciNumber(factor - 2)
}

func isPrime(number int) bool {

	if number == 2 {
		return true
	}

	divisor := 2

	for divisor = 2; divisor < number; divisor++ {
		if number % divisor == 0 {
			return false
		}
	}

	return true
}

func getPrimeNumber(factor int) int {

	index := 0
	iterator := 2
	result := 0

	for index < factor {

		if isPrime(iterator) {
			index += 1

			result = iterator
		}

		iterator += 1
	}

	return result
}

func enrichNumber(number int, factor int) int {

	number -= getPrimeNumber(factor)
	number += getFibonacciNumber(factor)

	return number
}