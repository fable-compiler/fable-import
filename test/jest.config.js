module.exports = {
    moduleFileExtensions: ['js', 'fs'],
    transform: {
      '^.+\\.(fs)$': 'jest-fable-preprocessor',
      '^.+\\.js$': 'jest-fable-preprocessor/source/babel-jest.js'
    },
    testMatch: ['**/**/*.(Test.fs)'],
    coveragePathIgnorePatterns: ['/packages/', 'test/']
  };