SELECT * FROM konyvek;
SELECT szerzo, cim, kiado FROM konyvek
SELECT * FROM konyvek WHERE kiado = "Móra"
SELECT * FROM konyvek WHERE kiado != "Móra"
SELECT * FROM konyvek WHERE nettoAr < 3000
SELECT * FROM konyvek WHERE megjelenes >= "2014-01-04"
SELECT * FROM konyvek WHERE szerzo LIKE "G%"
SELECT * FROM konyvek WHERE szerzo LIKE "%G%"
SELECT * FROM konyvek WHERE szerzo LIKE "_Ó%"
SELECT * FROM konyvek WHERE szerzo LIKE "Fekete István" And kiado = "Móra"
SELECT * FROM konyvek WHERE szerzo = "Fekete István" OR szerzo = "Gárdonyi Géza"
SELECT * FROM konyvek WHERE szerzo IN ("Gárdonyi Géza" , "Fekete István", "" )
SELECT * FROM konyvek WHERE szerzo NOT IN ("Gárdonyi Géza" , "Fekete István" ) 
SELECT * FROM konyvek WHERE kiado IN ("Európa" , "Móra" ) 
SELECT * FROM konyvek WHERE oldalszam IS NULL 
SELECT * FROM konyvek WHERE oldalszam IS NOT NULL 
SELECT * FROM konyvek WHERE megjelenes IS NULL 
SELECT * FROM konyvek WHERE megjelenes IS NOT NULL
SELECT * FROM konyvek WHERE nettoAr BETWEEN 2000 AND 3000 --Úgy veszi mint a kisebb egyenlő vagy nagyobb egyenlő
SELECT * FROM konyvek WHERE megjelenes BETWEEN "2014-01-01" AND "2014-12-31" = SELECT * FROM konyvek WHERE megjelenes LIKE "2014%" 
SELECT cim, nettoAr, nettoAr*1.27 FROM konyvek
SELECT cim, nettoAr, nettoAr*1.27 AS bruttoAr FROM konyvek
SELECT cim, nettoAr, round(nettoAr*1.27) AS bruttoAr FROM konyvek
--Aggregáló függvények
SELECT COUNT(*) FROM konyvek = SELECT COUNT(*)AS Darab FROM konyvek --darabszámban kiirja a konyeveket 
SELECT COUNT(oldalszam)AS Darab FROM konyvek
SELECT SUM(nettoAr)AS Ár FROM konyvek
SELECT SUM(nettoAr)AS Ár FROM konyvek WHERE kiado = 'Móra' 
SELECT round(AVG(oldalszam)),MIN(oldalszam) AS minoldalszam, MAX(oldalszam) AS maxoldalszam FROM konyvek
SELECT oldalszam, oldalszam+10 FROM konyvek
SELECT szerzo FROM konyvek
SELECT DISTINCT szerzo FROM konyvek
SELECT szerzo, COUNT(*) FROM konyvek GROUP BY szerzo
--karakter függvények
SELECT upper(szerzo), lower(cim) FROM konyvek
SELECT  concat(szerzo, ' - ', cim) AS hossz FROM konyvek
SELECT  szerzo, substr(szerzo,2,5) AS hossz FROM konyvek
SELECT  szerzo, substr(szerzo,5) AS hossz FROM konyvek
SELECT concat(lower(kiado), '@gmail.com') AS hossz FROM konyvek
SELECT rpad(kiado,25,'*') FROM konyvek
--ltrim --baldal
--rtrim --jobb oldalszam
--trim --mindkétoldal
SELECT sqrt(25), sqrt(-6), power(2,5), abs(-9), abs(10) 
SELECT `nettoAr`, round(sqrt(nettoAr),2) FROM konyvek
SELECT TRUNCATE(125.843653,2) 
SELECT TRUNCATE(125.843653,-2) 
SELECT ceil(6.1) 
SELECT floor(6.5) 
