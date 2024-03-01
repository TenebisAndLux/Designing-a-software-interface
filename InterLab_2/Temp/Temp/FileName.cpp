#include <string>
#include <iostream>
#include <vector>
#include <random>


class Sampler {
public:
	int get_random(const std::vector<int>& values) {
		std::uniform_int_distribution<> distrib(0, values.size() - 1);
		return values[distrib(gen)];
	}

	void createArr(int arr[], int size, std::vector<int> digits) {

		for (int i = 0; i < size; i++) {
			arr[i] = (0 + get_random(digits) * 51);
		}
	}

private:
	std::mt19937 gen;
};

int main() {
	Sampler s;
	const std::vector<int> digits = { 10, 1, 2, 3, 4, 5, 6, 7, 8 };

	int myRay[5];

	for (int j = 0; j < 15; j++) {
		s.createArr(myRay, 5, digits);

		for (int i = 0; i < 5; i++)
			std::cout << myRay[i] << std::endl;

		std::cout << std::endl;
	}
}