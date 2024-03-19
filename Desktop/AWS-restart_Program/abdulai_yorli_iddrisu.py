
accepted_names = ["Abdulai", "Yorli", "Iddrisu", "David", "Mohammed"]

# Get user input
user_name = input("Enter your name: ")

# Check if the user's name is in the list of accepted names
if user_name in accepted_names:
    print("User logged in")
else:
    print("User not logged in")
