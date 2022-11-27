DELETE FROM public."Grades";

INSERT INTO public."Grades"(
	"Id", "Name", "Order")
VALUES
    (gen_random_uuid(), 'Junior', 1),
    (gen_random_uuid(), 'Middle', 2),
    (gen_random_uuid(), 'Middle+', 3),
    (gen_random_uuid(), 'Senior', 4);