/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Views/**/*.cshtml', // Razor view dosyalar�
        './wwwroot/css/**/*.css', // CSS dosyalar�
        './wwwroot/js/**/*.js' // JavaScript dosyalar�
    ],
    theme: {
        extend: {},
    },
    plugins: [],
};
