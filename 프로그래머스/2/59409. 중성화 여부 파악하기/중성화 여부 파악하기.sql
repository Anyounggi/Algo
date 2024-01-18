-- 코드를 입력하세요
SELECT ANIMAL_ID, NAME, 
    CASE WHEN (SEX_UPON_INTAKE LIKE '%Neutered%' OR SEX_UPON_INTAKE LIKE '%Spayed%') 
        then 'O' 
        else 'X' 
    END AS '중성화'
FROM ANIMAL_INS
ORDER BY ANIMAL_ID