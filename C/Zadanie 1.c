#include <stdlib.h>
#include <math.h>

double sredniageo(double w, double x, double y, double z, double pier) {
    double liczba = w * x * y * z;
    double pierwiastek = pier;
    double srednia = pow(liczba, 1.0 / pierwiastek);
    return srednia;
}

int main() {
    double w, x, y, z, pier;


    printf("Wpisz liczbe w: \n");
    scanf("%lf", &w);

    printf("Wpisz liczbe x: \n");
    scanf("%lf", &x);

    printf("Wpisz liczbe y: \n");
    scanf("%lf", &y);

    printf("Wpisz liczbe z: \n");
    scanf("%lf", &z);

    printf("Wpisz wartosc stopnia pierwiastka: \n");
    scanf("%lf", &pier);

    if(pier>0){
        double wynik = sredniageo(w, x, y, z, pier);
        printf("Wynik %lf", wynik);
    }
    else{
        printf("Nieprawidlowy stopien pierwiastka! ");
    }
}