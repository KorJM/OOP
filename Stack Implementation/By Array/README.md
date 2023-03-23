<img width="1183" alt="스크린샷 2023-03-23 오후 3 53 51" src="https://user-images.githubusercontent.com/114234223/227130712-4e36098e-9412-4bfa-8a81-b18c9dc53b51.png">

Array를 사용한 Stack 구현입니다.

StackByArray 클래스를 Generic class로 정의하였습니다.

T[] items의 크기를 1로 초기화해주어 동적으로 크기를 할당하도록 하였고 Array의 pointer느낌인 top 변수를 -1로 초기화해주었습니다.

구현 메소드 : void push(), T pop(), T peek(), bool isEmpty(), int size()

기본적인 Stack의 기능들을 구현하였습니다.

void push() : Stack에 값을 추가하는 기능으로 값을 넣기전 top++해주어 순차적으로 들어가도록 하였습니다. 

만약 배열의 크기가 부족하면 2배씩 늘려주었습니다.

T pop() : item 변수에 배열의 맨 마지막 값을 할당해주고 top을 --해주어 마지막 값이 그 전 값이 되도록 해줍니다. 사실 값이 삭제되는 것이 아닌
pointer만 움직인 것입니다. Stack이 비었을 때 발생할 IndexOutOfRangeException은 try-catch를 사용하여 처리해주었습니다.

T peek() : 마지막 값을 그대로 리턴해주었습니다. 예외처리 방법도 T pop()과 같습니다.

bool isEmpty() : Stack이 비었는지 확인해주는 메소드입니다.

int size() : Stack 내부 요소의 갯수를 return하는 메소드입니다.

