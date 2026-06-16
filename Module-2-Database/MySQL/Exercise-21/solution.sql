-- Exercise 21: Top Feedback Providers

SELECT u.user_id, u.full_name, COUNT(f.feedback_id) AS feedback_count
FROM Feedback f
JOIN Users u ON u.user_id = f.user_id
GROUP BY u.user_id, u.full_name
ORDER BY feedback_count DESC
LIMIT 5;

