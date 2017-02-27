# blef
Blef to popularna wśród programistów jeżdzących na konferencje gra karciana. Zasady gry w Blefa dostępne są na wikipedii pod adresem https://pl.wikipedia.org/wiki/Blef_(gra)

##Cel
Wzięcie udziału w konkursie Daj Się Poznać. Zaimplementowanie prostej gdy karcianej, tak aby można pisać własne boty. W grupie znajomych uznaliśmy, że może być całkiem wesoło, aby zamiast grać, pisać boty który będą grały za nas.


##Założenia niefunkcjonalne
- Można się gniewać, nie można się obrażać.
- Nie mieszamy życia prywatnego z osobistym
- Dystans do siebie jest konieczny w tym projekcie

##Stack technologiczny
- ASP.NET
- SignalR
- Najlepsze dashboardy na rynku, i tak nie dojdziemy do konsensusu w kwestii który Framework FE jest najlepszy, więc będzie dużo różnych sexy dashboardów.

##Pierwsze taski (MVP)
- logika kolejności układów -> sprawdzanie układów
- jeden klient się rejestruje, gra z "kompem".
- komenda z servera do clienta, GetMove(...)?
- algorytm:
  - dummy algorytm, ten sam w kliencie i w serwerze grającym jako AI.
  - algorytm losowo albo podbija o jeden, albo sprawdza.
- wygrany/przegrany, następna gra z nowymi kartami.

- Po starcie serwera pokazanie strony z info (aby developer wiedział że Server działa).
