# Intuition
The goal is to reverse a segment of the input string word from index 0 to the index of the first occurrence of the character ch (inclusive). The task can be achieved by first finding the index of ch in word, reversing the substring from index 0 to the found index, and then combining the reversed substring with the rest of the original string.

# Approach
1. Start by finding the index of the first occurrence of the character ch in word. If the character is not found, return the original string word.
2. If the character ch is found, extract the segment of the string from index 0 to the index of ch (inclusive).
3. Reverse the extracted segment.
4. Create a new string by combining the reversed segment with the remaining part of the original string starting from the index of ch plus one.
5. Return the new string as the result.
# Complexity
- Time complexity:
The time complexity is primarily determined by the reversal operation on the segment. Finding the index of the first occurrence of ch in word takes at most O(n), where n is the length of the string word. Reversing the segment and creating the final string also requires linear time in the length of the segment. Therefore, the overall time complexity is O(n).
- Space complexity:
The space complexity is determined by the space needed to hold the reversed segment and the final string. Since the operations involve working with a substring of the original string and creating a new string, the space complexity is O(n), where n is the length of the string word.
