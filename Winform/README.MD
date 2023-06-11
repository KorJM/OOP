<h1>winform 프로그램 - 재고 관리</h1>
<hr>
<h3>원본 실행 화면 (체중 관리 프로그램)</h3> <br>

![원본코드첫화면](https://github.com/KorJM/OOP/assets/114234223/bdee570f-4ed9-4fe1-8fb3-63bbb05db476)

<br>

![원본코드추가화면](https://github.com/KorJM/OOP/assets/114234223/a1e08c91-75ca-49a2-9716-c02d16ff5856)

<br>
<span>단순한 정보 추가만 가능한 프로그램</span>
<br><br>
<h3>기능 추가한 재고 관리 프로그램</h3>
<br>
<span>초기 화면</span>
<br>

![재고관리 첫 화면](https://github.com/KorJM/OOP/assets/114234223/db0e79a2-0952-4a44-9be8-085c6da34412)

<br>
<h3>추가 된 기능</h3>
<li>추가 시 정확한 정보 입력 요구</li>
<li>삭제</li>
<li>전체 삭제</li>
<li>검색</li>
<li>이름 정렬</li>
<li>날짜 정렬</li>
<li>현재 날짜</li>
<li>현재 시간</li>
<li>종료 버튼</li>

<br>
<h3>기능 구현</h3>
<span> List컬렉션을 사용하여 정보를 저장하고 dataGridView를 사용해 정보를 출력하는 방식 </span>
<li>추가 : List 객체를 만들어 dataGridView.DataSource에 할당, try catch문을 사용하여 각각에 올바른 	정보를 넣지 않고 추가 버튼 클릭 시 MessageBox로 경고문 출력</li>
<li>삭제 : List 객체에서 선택 인덱스에 대해 RemoveAt후 다시 dataGridView.DataSource에 할당</li>
<li>전체삭제 : List.Clear후 dataGridView.DataSource = null;</li>
<li>검색 : List.Where(제품 => 제품.제품명.Contains(검색어)); 사용 후 해당 결과를 	dataGridView.DataSource에 할당</li>
<li>이름정렬 : List.OrderBy(제품 => 제품.제품명).ToList(); 후 dataGridView.DataSource에 할당</li>
<li>날짜정렬 : List.OrderBy(제품 => 제품.유통기한).ToList(); 후 
	      dataGridView.DataSource에 할당(중간에 '-'는 무시하고)</li>
<li>현재 날짜 : dateTimePicker사용 (오직 오늘 날짜만 볼 수 있도록 MaxDate, MinDate를 DateTime.Today로 조정)</li>
<li>현재 시간 : timer를 사용하여 label위에 띄움. label.Text = DateTime.Now.ToString("hh:mm:ss");
	       로 화면에 보이는 시간 형식 설정</li>
<li>종료 버튼: Button Click이벤트에 Application.Exit(); 작성</li>
  
  
