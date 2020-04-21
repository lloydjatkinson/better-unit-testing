module.exports = {
    root: true,
    env: {
        node: true,
    },
    extends: [
        'plugin:vue/base',
        'plugin:vue/essential',
        'plugin:vue/recommended',
        'plugin:vue/strongly-recommended',
        '@vue/airbnb',
    ],
    parserOptions: {
        parser: 'babel-eslint',
    },
    rules: {
        'no-console': process.env.NODE_ENV === 'production' ? 'error' : 'off',
        'no-debugger': process.env.NODE_ENV === 'production' ? 'error' : 'off',

        'max-len': ['error', 200],

        'import/extensions': ['error', 'never'],

        'no-iterator': 'off',

        'eol-last': ['error', 'never'],
        'linebreak-style': 'off',

        'space-before-function-paren': ['error', 'always'],

        indent: ['error', 4],

        'vue/html-indent': ['error', 4, {
            attribute: 1,
            closeBracket: 0,
            alignAttributesVertically: true,
            ignores: [],
        }],

        'vue/html-closing-bracket-newline': ['error', {
            singleline: 'never',
            multiline: 'never',
        }],
    },
    overrides: [
        {
            files: [
                '**/__tests__/*.{j,t}s?(x)',
                '**/tests/unit/**/*.spec.{j,t}s?(x)',
            ],
            env: {
                jest: true,
            },
        },
    ],
};