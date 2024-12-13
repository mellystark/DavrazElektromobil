/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Views/**/*.cshtml', // Razor view dosyalarý
        './wwwroot/css/**/*.css', // CSS dosyalarý
        './wwwroot/js/**/*.js' // JavaScript dosyalarý
    ],
    theme: {
        extend: {},
    },
    plugins: [],
};
