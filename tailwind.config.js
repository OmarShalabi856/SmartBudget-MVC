module.exports = {
    content: [
        "./Views/**/*.cshtml", // Include all Razor views in the Views folder
        "./wwwroot/css/*.css" // Include any additional CSS files in wwwroot/css
    ],
    theme: {
        extend: {}, // Add custom Tailwind classes here
    },
    plugins: [], // Add any Tailwind plugins here
};
