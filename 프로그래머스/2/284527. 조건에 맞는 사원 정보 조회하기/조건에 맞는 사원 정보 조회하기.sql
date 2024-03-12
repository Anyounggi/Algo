SELECT SUM(B.SCORE) AS SCORE, A.EMP_NO, A.EMP_NAME, A.POSITION, A.EMAIL
FROM HR_EMPLOYEES A JOIN HR_GRADE B
ON A.EMP_NO = B.EMP_NO
GROUP BY YEAR, EMP_NO
HAVING B.YEAR = '2022'
ORDER BY 1 DESC
LIMIT 1;