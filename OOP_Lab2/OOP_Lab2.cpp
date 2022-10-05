#include <iostream>
#include <math.h>
#include <stdio.h>
using namespace std;

class Sphere {

public:
	double R, V;
	Sphere() { //Конструктор без параметрів//
		this->R = 0;
	}

	Sphere(double R, double V) { //Конструктор з параметрами//
		this->R = R;
	}

	~Sphere() {}

	double getRadius() {
		return R;
	}

	void setRadius(double R) {
		this->R = R;
	}

	double setVolume(double V) {
		return V;
	}

	double getVolume(double R) {
		return (4 * 3.14 * R * R * R) / 3;
	}

	friend Sphere frd(Sphere s1, Sphere s2);
};

void print_val(Sphere sphere) {
	cout << "Radius = " << sphere.getRadius() << "\n" << "Volume = " << sphere.getVolume(sphere.R) << "\n";
}

Sphere frd(Sphere s1, Sphere s2) {
	Sphere s3;
	double newVolume = s3.setVolume(s1.getVolume(s1.R) + s2.getVolume(s2.R));
	s3.setRadius(cbrt(3 * newVolume / (4 * 3.14)));
	return s3;
}

int main()
{
	Sphere s1, s2;
	double R1, R2;

	cout << "Enter First Radius: ";
	cin >> R1;
	cout << "Enter Second Radius: ";
	cin >> R2;
	cout << "\n";

	s1.setRadius(R1);
	s2.setRadius(R2);

	cout << "Volume of the first sphere: " << s1.getVolume(R1) << "\n" << "Volume of the second sphere: " << s2.getVolume(R2) << "\n\n";

	Sphere s3 = frd(s1, s2);

	cout << "Sphere 3: \n";
	print_val(s3);


	return 0;
}