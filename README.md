1.ความเป็นมาของโปรแกรม
```
ปัญหาคือ มีผู้ที่มาจองห้องพักจำนวนมาก และทำให้พนักงานม่ไม่พอเพียงต่อลูกค้า จึงทำขึ้นเพื่อความสะดวกและรวดเร็วต่อการจองห้องพัก
```
2.วัตถุประสงค์ของโปรแกรม
``` 
1) เพื่อให้ผู้ที่มาพักเจอปัญหาห้องพักเต็ม
2) สามารถจองได้อย่างสะดวกและรวดเร็ว
3) มีการคำนวณราคาที่ถูกต้อง ไม่กลัวทอนเงินขาดหรือเกิน
4) สามารถเก็บเป็นข้อมูลได้ จะได้ไม่สับสนเวลาคนมาจองจำนวนมาก
```
3.โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown  
Class Diagram
```mermaid
classDiagram
  direction LR
  class from1{
  -inputMember():void
  -Pay():void
  -OpenFile():void
  -SaveFile():void
}

class inputMember{
  -Comfirm():void
  -Clear():void
}

  class Member{
  -Name():void
  -ID():void
  -Phone():void
  -DateTime():void
  -Room():void
}

  class Room{
  +Pirce():void
}

  class RoomA{
  +RoomA():void
}

  class RoomB{
  +RoomB():void
}

  class RoomC{
  +RoomC():void
}

  class RoomD{
  +RoomD():void
}
  class RoomE{
  +RoomE():void
}

  class Buy{
  +getbill():void
}

  class Pay{
  -Pay():void
  -CloseProgram():void
}
 
 Member -- from1
 
  from1 -- inputMember
  from1 -- Room
  from1 -- Pay
  
  Pay -- Buy

  Room -- RoomA
  Room -- RoomB
  Room -- RoomC
  Room -- RoomD
  Room -- RoomE
```
4.ชื่อของผู้พัฒนาโปรแกรม
```
นาย วรโชติ ทองเลิศ 653450299-0
```
