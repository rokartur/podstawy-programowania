# Podstawy programowania

## Zadanie 1.
1. Utwórz katalog `repo1` i dwa pliki tekstowe:
    ```bash
    mkdir repo1
    cd repo1
    echo "plik 1" > file1.txt
    echo "plik 2" > file2.txt
    ```
2. Utwórz repozytorium git i sprawdź jego stan:
    ```bash
    git init && git status
    ```
3. Dodaj pliki do repozytorium i sprawdź jego stan:
    ```bash
    git add . && git status
    ```
4. Zakomituj zmiany i sprawdź stan repozytorium:
    ```bash
    git commit -m "initial commit" && git status
    ```

## Zadanie 2.
1. Zmodyfikuj zawartość jednego z plików i sprawdź stan repozytorium:
    ```bash
    echo "zmieniona zawartosc" > file1.txt && git status
    ```
2. Zmodifikuj zawartość drugiego pliku i wyświetl różnice:
    ```bash
    echo "zmieniona zawartosc" > file2.txt && git diff file2.txt
    ```
3. Zakomituj zmiany:
    ```bash
    git add . && git commit -am "zmieniono zawartosc plikow"
    ```
4. Wyświetl historię zmian:
    ```bash
    git log
    ```

## Zadanie 3.
1. Sklonuj repozytorium repo1 jako repo2:
    ```bash
    cd .. && git clone repo1 repo2
    ```

## Zadanie 4.
1. Usuń jeden z plików i zmien nazwe drugiego:
    ```bash
    cd repo2 && git rm file1.txt && git mv file2.txt newfile.txt
    ```
2. Sprawdź stan repozytorium i zakomituj zmiany:
    ```bash
    git status && git commit -am "usunieto file1 i zmieniono nazwe file2"
    ```
3. Wyswietl historie zmian z pokazaniem nazw plików:
    ```bash
    git log --stat
    ```

## Zadanie 5.
1. Zaktualizuj stan repo1:
    ```bash
    cd ../repo1 && git pull
    ```

## Zadanie 6.
1. Zmodyfikuj plik tekstowy w repo1 i repo2:
    ```bash
    echo "zmiana w repo1" > newfile.txt && cd ../repo2 && echo "zmiana w repo2" > newfile.txt
    ```
2. Zakomituj zmiany w obu repozytoriach:
    ```bash
    git commit -am "zmiana w repo2" && cd ../repo1 && git commit -am "zmiana w repo1"
    ```
3. Sprobuj zaktualizowac stan repo1:
    ```bash
    git pull ../repo2
    ```
4. Rozwiaz konflikt, sprawdz stan repozytorium i wyswietl historie zmian:
    ```bash
    git add . && git commit -m "rozwiazano konflikt" && git status && git log
    ```
5. Zaktualizuj stan repo2:
    ```bash
    cd ../repo2 && git pull ../repo1
    ```   

## Zadanie 7.
1. Przywróć stan kopii roboczej do stanu repozytorium sprzed zadania 6:
    ```bash
   git checkout HEAD~1 && git status
   cat newfile.txt
   git checkout HEAD && git status
   ```

## Zadanie 8.
1. Wyswietl zawartość pliku przed dokonaniem modyfikacji:
    ```bash
    git show HEAD~1:newfile.txt
    ```

## Zadanie 9.
1. Wyswietl róznice stanu obecnego pliku i stanu przed modyfikacjami:
    ```bash
    git diff HEAD~1 HEAD newfile.txt
    ```

## Zadanie 10.
1. Utwórz nowy branch i zmodyfikuj plik:
    ```bash
    git checkout -b test && echo "zmiana w nowym branchu" > newfile.txt
    git commit -m "zmiana w branchu test"
    ```
2. Wyświetl informacje o branchach, wróć do main i wyswietl zawartość pliku:
    ```bash
    git branch && git checkout main && cat newfile.txt && git status
    ```

## Zadanie 11.
1. Zaciągnij zmiany z repo1 do repo2:
    ```bash
    cd ../repo2 && git pull ../repo1 test
    ```
2. Wyswietl stan repozytorium, informacje o branchach i historie:
    ```bash
    git status && git branch && git log
    ```
   
## Video

https://github.com/rokartur/podstawy-programowania/assets/79342641/402e67aa-0774-4b1e-a604-f3d0da3682f7
