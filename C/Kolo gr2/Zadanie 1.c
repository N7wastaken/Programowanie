#include "stdlib.h"
#include "math.h"

double sredniageo(double w, double x, double y, double z, int pier){
    double liczba = w*x*y*z;
    double stopienpierwiastka = pier;
    double srednia;

    if (liczba < 0 && pier % 2 == 0) {
        printf("Nieprawidlowe dane, pod pierwiastkiem o stopniu parzystym nie moze znalezc sie liczba ujemna!\n");
        exit(1);
    } else {
        srednia = pow(liczba, 1.0 / stopienpierwiastka);
    }

    return srednia;
}

int main(){

    double w, x, y, z;
    int pier;

    printf("Wpisz wartosc stopnia pierwiastka: \n");
    scanf("%d",&pier);

    printf("Wpisz liczbe w: \n");
    scanf("%lf",&w);

    printf("Wpisz liczbe w: \n");
    scanf("%lf",&x);

    printf("Wpisz liczbe w: \n");
    scanf("%lf",&y);

    printf("Wpisz liczbe w: \n");
    scanf("%lf",&z);

        double wynik = sredniageo(w,x,y,z,pier);
        printf("Wynik to: %lf \n",wynik);


}
