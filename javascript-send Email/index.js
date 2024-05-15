document.addEventListener('DOMContentLoaded', function() {
  const btn = document.getElementById('button');
  const form = document.getElementById('form');

  form.addEventListener('submit', function(event) {
    event.preventDefault();

    btn.textContent = 'Sending...';

    const serviceID = 'service_1e4fj8h';
    const templateID = 'template_tox677s';

    const formData = {
      from_name: document.getElementById('from_name').value,
      email_id: document.getElementById('email_id').value,
      message: document.getElementById('message').value
    };

    emailjs.send(serviceID, templateID, formData)
      .then(() => {
        btn.textContent = 'Send Email';
        alert('Email sent successfully!');
        form.reset();
      })
      .catch((err) => {
        btn.textContent = 'Send Email';
        alert('An error occurred while sending the email. Please try again later.');
        console.error('EmailJS error:', err);
      });
  });
});
