-- Exercise 01: User Upcoming Events
-- Parameters: :user_id

SELECT e.*
FROM Users u
JOIN Registrations r ON r.user_id = u.user_id
JOIN Events e ON e.event_id = r.event_id
WHERE u.user_id = /* :user_id */ 1
  AND e.city = u.city
  AND e.start_date >= CURDATE()
ORDER BY e.start_date;
