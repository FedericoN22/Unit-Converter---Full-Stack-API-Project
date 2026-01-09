
    const tabs = document.querySelectorAll('.tab');
    const panels = document.querySelectorAll('.panel');
    const button = document.querySelectorAll('.convert-btn');
    const FromBtn = document.getElementsByClassName('form-group');


                  


    tabs.forEach(tab => {
        tab.addEventListener('click', () => {

            // Remove active from all tabs
            tabs.forEach(t => t.classList.remove('active'));

            // Add active to clicked tab
            tab.classList.add('active');

            // Hide all panels
            panels.forEach(p => p.classList.remove('active'));

            // Show the correct panel
            const target = tab.getAttribute('data-target');
            document.getElementById(target).classList.add('active');
        });
    });

    button.forEach(btn => {
     btn.addEventListener('click', async () => {
    
        const tabActive = document.querySelector('.tab.active').getAttribute('data-target');
        let value = '';
        let from = '';
        let to = '';



        switch (tabActive) {
            case 'length':
                // Handle length conversion
                console.log("Length conversion");
                 value = document.getElementById('length-value').value;
                 from = document.getElementById('length-from').value;
                 to = document.getElementById('length-to').value;
                 break;
            case 'weight':
                // Handle weight conversion
                 value = document.getElementById('weight-value').value;
                 from = document.getElementById('weight-from').value;
                 to = document.getElementById('weight-to').value;
                break;
            case 'temperature':
                // Handle temperature conversion
                 value = document.getElementById('temp-value').value;
                 from = document.getElementById('temp-from').value;
                 to = document.getElementById('temp-to').value;
                break;
        }


        const url = `http://localhost:5296/convert/${tabActive}?value=${value}&from=${from}&to=${to}`;

        const response = await fetch(url);
        const data = await response.json();
        
        if (tabActive === 'length') {
            document.getElementById('result-length').innerText = `Result: ${data.result}`;
        } else if (tabActive === 'weight') {
            document.getElementById('result-weight').innerText = `Result: ${data.result}`;
        } else if (tabActive === 'temperature') {
            document.getElementById('result-temp').innerText = `Result: ${data.result}`;
        }
     });
    
    });


    

    
    

