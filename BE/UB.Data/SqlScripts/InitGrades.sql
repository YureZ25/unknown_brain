DELETE FROM public."Grades";

INSERT INTO public."Grades"(
	"Id", "Name", "Order", "Recomendation")
VALUES
    ('dd06ccd9-4197-4c5b-9dfa-74533078f4c2', 'Junior', 1, 'Как джуниору стать миддлом? Читай, смотри, расти 😉'),
    ('48597f8d-743a-4718-8df2-cce36c6bb547', 'Middle', 2, 'А ты хорош, но можно лучше)) Читай, смотри, расти в зарплате 😉'),
    ('fd291452-1b4d-42a4-8a59-b7bd501ec5aa', 'Middle+', 3, 'А ты хорошо, но можно лучше)) Читай, смотри, расти в зарплате 😉'),
    ('8c632a14-c509-4fb0-942b-b6787573e0fb', 'Senior', 4, 'А ты Хорош) Тебе нечего посоветовать, кроме как увеличить зарплату😁')
ON CONFLICT ("Id") DO UPDATE
    SET "Recomendation" = EXCLUDED."Recomendation";