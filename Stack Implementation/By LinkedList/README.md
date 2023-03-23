<img width="1183" alt="스크린샷 2023-03-23 오후 3 51 24" src="https://user-images.githubusercontent.com/114234223/227127331-d7d509aa-7e20-4a2f-a50f-197a9b6ca3c4.png">


LinkedList를 사용한 Stack 구현입니다.

StackByLinkedList 클래스를 Generic class로 정의하였습니다.

구현 메소드 : T push(), T pop(), T peek(), int count(), bool isEmpty(), void clear()


기본적인 Stack 기능들을 구현하였습니다.

T push() : Stack에 값을 추가하는 기능으로 LinkedList의 AddFirst() 메소드를 사용하여 추가해주었습         
           니다.

T pop() : try-catch를 사용하여 스택이 비어있는데 호출 되었을 시의 발생할 NullReferenceException                   
          을 방지하였습니다.
          
          First.Value를 사용하여 T value 변수에 Stack에 있는 첫번째 값을 할당시켜 주었고 이후
          
          RemoveFirst()를 사용하여 삭제 시켜주었습니다. 빈 스택일 때는 호출시 콘솔에 스택이 비었다는 
          
          문자를 출력시키고 return이 필요하기에 defalut(T)값을 return하였습니다.

T peek() : T pop()과 거의 유사하며 삭제를 시킬 필요가 없기에 First.Value를 바로 return 하였습니다.
           
           예외처리 또한 똑같이 해주었습니다.

int count() : Stack에 있는 요소들의 갯수를 return하는 메소드입니다.

bool isEmpty() : Stack이 비어있는지 확인하는 메소드입니다.

void clear() : Stack을 완전히 비워주는 메소드입니다.
