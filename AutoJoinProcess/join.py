import mysql.connector
import pyautogui
import time
from datetime import datetime

# startClass automation
def startClass(id, passcode):
    pyautogui.hotkey('win')
    pyautogui.write("zoom")
    time.sleep(2)

    pyautogui.hotkey('enter')
    time.sleep(5)

    pyautogui.click("JoinMeeting.png")
    time.sleep(5)

    pyautogui.write(id)
    pyautogui.hotkey("enter")
    time.sleep(5)

    pyautogui.write(passcode)
    pyautogui.hotkey("enter")

# connection to database
mydb = mysql.connector.connect(
    host="localhost",
    user="root",
    passwd="mclejova372",
    database="zoomdb"
)

# data retrieval
mycursor = mydb.cursor(buffered=True)
mycursor.execute("SELECT meetingid,meetingpasscode,starttime, endtime, dayofweek FROM classes")
myresult = mycursor.fetchall()

for row in myresult:
    id,passcode,start,end,day = ([] for i in range(5))
    id.append(row[0])
    passcode.append(row[1])
    start.append(row[2])
    end.append(row[3])
    day.append(row[4])
    
# wait for class start
while True:
    for i in range(len(start)):   
        if((int(datetime.now().hour) > int(start[i].split(':')[0]) or (int(datetime.now().hour) == int(start[i].split(':')[0]) 
        and int(datetime.now().minute) >= int(start[i].split(':')[1]))) and (int(datetime.now().hour) < int(end[i].split(':')[0]) or 
        (int(datetime.now().hour) == int(end[i].split(':')[0]) and int(datetime.now().minute) < int(end[i].split(':')[1])))):   
            #print("DTH: ",datetime.now().hour, "STH: ", end[i].split(':')[0], "DTM: ", datetime.now().minute, "STM: ", end[i].split(':')[1])
            startClass(id[i],passcode[i])
            # adjust for lecture time
            time.sleep(3600)

    