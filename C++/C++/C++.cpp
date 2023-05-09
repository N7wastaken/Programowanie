#include<iostream>
#include<string>
#include<cstring>
#include<bits/stdc++.h>
#include<cmath>
using namespace std;

//1
void odliczanie(){

	int i;
	cin>>i;
	
	while(i>0){
		cout<<i;
		cout<<endl;
		i--;
	}
	}
	
//2
void stringi(){

	string imie;
	string nazwisko;
	
	
		cin>>imie>>nazwisko;
	
	string full=imie+" "+nazwisko;
	
		cout<<full;
		cout<<endl;
		cout<<nazwisko<<" "<<imie;
		cout<<endl;
		cout<<imie[0]<<nazwisko[0];
		cout<<endl; 
	
	int a;
	a=imie.size();

	while(a>=0){
		cout<<imie[a];
		a--;
	}
	
		cout<<" ";
	
	int b;
	b=nazwisko.size();
	
	while(b>=0){
		cout<<nazwisko[b];
		b--;
	}
	
		cout<<endl;
	
	swap(imie[0], nazwisko[0]);
	cout<<imie<<nazwisko;
	
}

//3
void stringchar(){

	char im[]="";
	cin>>im;
	string imie = im;
	cout<<imie;
		
}
	
//4
int policzlit(string sentence){

	int dlugosc=sentence.size();
	int ia=0;
	for (int i=0; i < dlugosc; i++)
		if (sentence[i] != ' ') ia++;
	return ia;
}


//5
int literylicz(string sentencea, char l){

	int dl=sentencea.size();
	int ib=0;
	for (int i=0; i < dl; i++)
		if (sentencea[i] == l) ib++;
	return ib;
}

		
//6
void bezwzlicz(){
	
	double a,b,c;
	cin>>a>>b>>c;
	if(a<0){
		a=-a;
	}
	if(b<0){
		b=-b;
	}
	if(c<0){
		c=-c;
	}
	double suma = a + b + c;
	cout<<"Suma tych liczb jest rowna "<<suma;
}

//7
void najztrzech(){
	
	double a,b,c;
	cin>>a>>b>>c;
	
	double naj = max(a,b);
	double najnaj = max(naj,c);
	cout<<"Najwieksza liczba to "<<najnaj;
}

//8
void booltroj(){
	
	double a,b,c;
	cin>>a>>b>>c;
	
	bool trojkat;
	bool positivum;
	double naj = max(a,b);
	double najnaj = max(naj,c);
	
	if(najnaj<a+b&&a>0&&b>0&&c>0||najnaj<a+c&&a>0&&b>0&&c>0||najnaj<b+c&&a>0&&b>0&&c>0){
		trojkat = true;
		
	}
	if(najnaj>a+b&&a>0&&b>0&&c>0||najnaj>a+c&&a>0&&b>0&&c>0||najnaj>b+c&&a>0&&b>0&&c>0){
		trojkat=false;
		cout<<"Podane liczby nie sa stronami trojkata ";
		cout<<endl;
		
	}
	if(a<=0||b<=0||c<=0){
		positivum=false;
	
	}
	else{
		positivum=true;
	}
	if(trojkat==true){
		cout<<"Podane liczby sa bokami trojkata ";
		cout<<trojkat;
		cout<<endl;
	}
	if(positivum==false){
		
		cout<<"Error: Numbers should be positive ";
		cout<<positivum;	
		
	}
	if(positivum==true){
		cout<<" ";
	}

}

//9
void trojkapi() {
	
	int a, b, c;
	int a1, b1, c1;

	cout << "Wpisz 3 liczby: ";
	cout << endl;

	cin >>a>>b>>c;

	a1 = a * a;
	b1 = b * b;
	c1 = c * c;

	if (a1 + b1 == c1 || b1 + c1 == a1 || a1 + c1 == b1) {
		cout << "Podane liczby stanowia trojke pitagorejska ";
	}
	else {
		cout << "Podane liczby nie sa trojka pitagorejska";
	}
}

//10
void tablicasc(){

for (int i=33; i<256; i++){
  cout.width(4);
  cout  << (char) (i);
  cout.width(4);
  cout << i;
  if (i % 8 == 0) cout << endl;
  
}

}

//11
string szyfrowanie(string santance, int liczb){

	int leng=santance.size();
	for (int i=0; i < leng; i++){
		santance[i] = char(int(santance[i]) + liczb);
	}
	return santance;
}

//12
string szyfrowanietegorsze(string sen){
	int len=sen.size();
	for (int i=0; i < len; i=i+2){
		char uno=sen[i];
		char dos=sen[i+1];
		sen[i]=dos;
		sen[i+1]=uno;
	}
	return sen;
}

//13
int liczsamogloski(string se){

	string samog="aAeEiIoOuUyY";
	int ilosc=0;
	int lengt=se.size();
	for (int i=0; i < lengt; i++)
		if (samog.find(se[i]) < lengt) ilosc++;

	return ilosc;
}

//14
int liczspolgloski(string ses){

	string samogs="bBcCdDzZfFgGhHjJkKlLmMnNpPrRsStTwW";
	int iloscs=0;
	int lengts=ses.size();
	for (int i=0; i < lengts; i++)
		if (samogs.find(ses[i]) < lengts) iloscs++;

	return iloscs;
}

//15
int liczslowa(string zdanie){

	int count=0;
	int lo=zdanie.size();
	for (int i=0; i < lo; i++)
		if (zdanie[i] == ' ') count++;
	
	return count+1;
}

//16
void poradnia(int a){


	if(a<=11&&a>=5){

		cout<<"Morning ";

		}	

	if(a==12){

		cout<<"Noon ";

		}

	if(a<=17&&a>=13){

		cout<<"Afternoon ";

		}

	if(a<=20&&a>=18){

		cout<<"Evening ";

		}

	if(a<=23&&a>=21||a>=1&&a<=4){

		cout<<"Night ";

		}

	if(a==24){
	
		cout<<"Mindnight";
	
		}

	if(a<0){
	
		cout<<"Error";
	
		}
}

//17
void najwd(){
	
	int a,b;
	cout << "Podaj 2 liczby: ";
	cin >>a>>b;
	cout << "Najwiekszy wspolny dzielnik (" << a << "," << b << ") = ";
	while (a != b)
	{
	if (a < b)
	b = b-a;
	else
	a = a-b;
	}
	cout << a << endl;
	}

//18
void silnia(){
	
	long double a;
	long double sil;
	cin>>a;
	sil=1;
	while(a>0){
	
	sil=sil*a;
	a--;
	
	}
		cout<<sil;
	}
	
int main(){
	
			cout<<"Wpisz 1 aby odliczyc od podanej liczby w dol ";
			cout<<endl;
			cout<<"Wpisz 2 aby odpalic nazwiska ";
			cout<<endl;
			cout<<"Wpisz 3 aby zamienic char na string";
			cout<<endl;
			cout<<"Wpisz 4 aby policzyc litery w zdaniu ";
			cout<<endl;
			cout<<"Wpisz 5 aby policzyc ilosc wystepowania litery w zdaniu ";
			cout<<endl;
			cout<<"Wpisz 6 aby dodac wartosci bezwzgledne 3 liczb ";
			cout<<endl;
			cout<<"Wpisz 7 aby wyswietlic najwieksza z podanych 3 liczb ";
			cout<<endl;
			cout<<"Wpisz 8 aby sprawdzic czy 3 podane liczby to strony trojkata ";
			cout<<endl;
			cout<<"Wpisz 9 aby sprawdzic czy 3 podane liczby to trojka pitagorejska ";
			cout<<endl;
			cout<<"Wpisz 10 aby wyswietlic tablice kodow ASCII ";
			cout<<endl;
			cout<<"Wpisz 11 aby zaszyfrowac podany text ";
			cout<<endl;
			cout<<"Wpisz 12 aby zaszyfrowac podany text [przestawianie] ";
			cout<<endl;
			cout<<"Wpisz 13 aby policzyc samogloski w podanym zdaniu ";
			cout<<endl;
			cout<<"Wpisz 14 aby policzyc spolgloski w podanym zdaniu ";
			cout<<endl;
			cout<<"Wpisz 15 aby zliczyc ilosc slow w podanym zdaniu ";
			cout<<endl;
			cout<<"Wpisz 16 aby sprawdzic pore dnia ";
			cout<<endl;
			cout<<"Wpisz 17 aby policzyc najwiekszy wspolny dzielnik 2 podanych liczb ";
			cout<<endl;
			cout<<"Wpisz 18 aby policzyc silnie z podanej liczby ";
			cout<<endl;
		
	int wybor;
		cin>>wybor;
		
		if(wybor==1){
	
		odliczanie();
		return 0;
	
		}
	
		if(wybor==2){
	
		stringi();
		return 0;
	
		}
		
		if(wybor==3){
			
		stringchar();
		return 0;
		
		}
		
		if(wybor==4){
			
		string zdanie;
		cout << "zdanie: ";
		cin.ignore(1);
		getline(cin,zdanie);
		cout << policzlit(zdanie) << endl;
		return 0;
		
		}
		
		if(wybor==5){
		
		string wyr;
		char lit;
		cout << "napis i litera: ";
		cin >> wyr>>lit;
		cout <<"ilosc "<<lit<<"="<< literylicz(wyr,lit) << endl;;
		return 0;
		
		}
		
		if(wybor==6){  
		
		cout<<"Wpisz liczby: ";
		bezwzlicz();
		return 0;
		
		}
		if(wybor==7){
		
		cout<<"Wpisz liczby: ";
		najztrzech();
		return 0;
		
		}
		
		if(wybor==8){
		
		cout<<"wpisz boki trojkata: ";
		booltroj();
		return 0;
		
		}
		
		if(wybor==9){
		
		trojkapi();
		return 0;
		
		}
		
		if(wybor==10){
		
		tablicasc();
		return 0;
		
		}
		
		if(wybor==11){
		
		string kod;
		int liczb;
		cout << "Wpisz zdanie: ";
		cin.ignore(1);
		getline(cin,kod);
		cout << "Wpisz liczbe do szyfrowania: ";
		cin >> liczb;
		kod=szyfrowanie(kod,liczb);
		cout << kod << endl;

		return 0;
		
		}
		
			if(wybor==12){
		
		string nap;
		cout << "Wpisz zdanie: ";
		cin.ignore(1);
		getline(cin,nap);
		nap=szyfrowanietegorsze(nap);
		cout << nap << endl;
		
		return 0;
		}
		
		if(wybor==13){
		
		string wpis;
		cout << "Wpisz zdanie: ";
		cin.ignore(1);
		getline(cin,wpis);
		cout << liczsamogloski(wpis) << endl;
	
		return 0;
		}
		
			if(wybor==14){
		
		string wpiss;
		cout << "Wpisz zdanie: ";
		cin.ignore(1);
		getline(cin,wpiss);
		cout << liczspolgloski(wpiss) << endl;
		
		return 0;
		}
		
			if(wybor==15){
		
		string slowo;
		cout << "Wpisz zdanie: ";
		cin.ignore(1);
		getline(cin,slowo);
		cout << liczslowa(slowo) << endl;
		
		return 0;
		}
		
			if(wybor==16){
		
		int por;
		cout<<"Wpisz godzine: ";
		cin>>por;	
		cout<<"Pora dnia: ";
		poradnia(por);
	
		return 0;
		}
		
			if(wybor==17){
		
		najwd();
		return 0;
		
		}
		
		
			if(wybor==18){
		
		silnia();
		return 0;
		
		}
		
		else{
			cout<<"Error";
		}
		return 0;
}
