# s32429_apbd_cw1
Paweł Gębicki s32429 - Aplikacje Baz Danych - Ćwiczenie 1


1. Kiedy Git zrobi fast‑forward, a kiedy powstaje merge commit?

Fast‑forward - gdy gałąź docelowa nie ma własnych commitów, a obecna gałąź jest po prostu dalej w historii. Git może wtedy przesunąć wskaźnik bez tworzenia nowego commita.

Merge commit - gdy obie gałęzie mają różne historie, więc Git musi je połączyć, tworzy dodatkowy commit scalający.

2. Czym w praktyce różni się merge od rebase?

Merge łączy dwie historie takimi, jakie są. Zachowuje pełną chronologię i tworzy merge commit.

Rebase przepisuje historię — przenosi commity na koniec innej gałęzi, tworząc liniową historię bez merge commitów.

3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?

Zdecydowałem się na wypisanie na ekran tylko jednej rzeczy - średniej z tablicy numbers
